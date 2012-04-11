#!/usr/bin/python

import socket
import fcntl
import struct
import MySQLdb as db
import sys

def get_ip_address(ifname):
    s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    return socket.inet_ntoa(fcntl.ioctl(
        s.fileno(),
        0x8915,  # SIOCGIFADDR
        struct.pack('256s', ifname[:15])
    )[20:24])

def connect_db(target_host, query):
	#connection variables
	con = None
	host = target_host
	user = 'client'
	passwd = ''
	database = 'raichu'

	try:
		con = db.connect(host, user, passwd, database)

		with con:
			cur.execute(query)

	except db.Error,e:
		print "Database error %d: %s" % (e.args[0], e.args[1])
		return False
	finally:
		if con:
			con.close()
	return True


s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
#host = socket.gethostname()
#host = socket.gethostbyname(socket.gethostname())

#specified for linux vm
host = get_ip_address("eth3")
#school designated ports 33XXX
port = 33333

try:
	s.bind((host, port))
except socket.error,e:
	print "Error %d: %s" % (e.args[0], e.args[1])
	sys.exit(1)

#TODO multithread this part
s.listen(5)

print "listening for devices..."

#TODO use catch exceptions
try:
	while True:

		conn, addr = s.accept()
		print "%s is connected" %  addr[0]
		data = conn.recv(1024)

		if len(data) > 0:
			#write data into database
			print "Recieved %s" % data
			#TODO construct query and send to database
			conn.send("ok")

		conn.close()

except socket.error,e:
	print "Error %d: %s" % (e.args[0], e.args[1])

finally:
	if s:
		s.close()
