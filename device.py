#!/usr/bin/python

import socket
import sys
import datetime as dt
import time as t
import simplejson as json


def print_error(error):
	print "Error %d: %s" % (error.args[0], error.args[1])

def get_timestamp():
	return dt.datetime.fromtimestamp(int(t.time())).strftime('%Y-%m-%d %H:%M:%S')

def boot_up(s):
	s.connect ((host, int(port)))
	print s.getpeername()
	s.send (json.dumps (device_info))
	server_response = s.recv(1024)
	if server_response != "":
		print server_response

if __name__ == "__main__":
	s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	
	s.setblocking (1)
	host = sys.argv[1]
	port = sys.argv[2]

	# may need to add on more info later on
	device_info = {
		'type'		  : 'device',
		'name'		  : 'device_' + dt.datetime.fromtimestamp(int(t.time())).strftime('%H%M%S'),
		'bootup-time' : get_timestamp(),
	}

	try:
		boot_up (s)
		t.sleep(1)

		print device_info["name"] + " start up"

		try:
			while True:
				data = s.recv(1024)
				if data != "":
					# socket is alive
					print data
				elif data == "ping":
					s.send("alive")
				else:
					# socket is no longer alive
					break
		except socket.error, e:
			print_error(e)
			
		print device_info["name"] + " shutdown"
	except socket.error, e:
		print_error(e)
	finally:
		if s:
			s.close()