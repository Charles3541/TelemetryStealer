#! /usr/bin/python

import socket, struct, sys, os

s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
s.bind(("localhost", 2800))

TypeFormats = [
    "",     # null
    "d",    # double (float64)
    "?",    # bool
    "ddd"]  # Vector3d


class Packet:
    def __init__(self, data):
        self.data = data
        self.pos = 0

    def get(self, l):  # get l bytes
        self.pos += l
        return self.data[self.pos - l:self.pos]

    def read(self, fmt):  # read all formatted values
        v = struct.unpack(fmt, self.get(struct.calcsize(fmt)))
        if len(v) == 1: return v[0]
        return v

    @property
    def more(self):  # is there more data?
        return self.pos < len(self.data)


def readPacket(dat):
    p = Packet(dat)
    messageType = p.read("B")

    if messageType == 1:
       return
    elif messageType == 2:
        messageLen = p.read("I")
        message = p.get(messageLen).decode('utf-8')
        print(f"{message}")
        lis = message.split("ç")
        for i, s in enumerate(lis):
            with open(f'rec/{i}.txt', 'w') as file:
                file.write(s)
    else:
        raise Exception("uhhhh something went wrong")
    sys.stdout.flush()


sys.stderr.write("Awaiting connection...\nYou can minimize this window! Just don't close it!\n")
while 1:
    d, a = s.recvfrom(2048)
    readPacket(d)
