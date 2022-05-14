class BufferFullException(BufferError):
    """Exception raised when CircularBuffer is full.

    message: explanation of the error.

    """
    def __init__(self, message):
        self.message = message


class BufferEmptyException(BufferError):
    """Exception raised when CircularBuffer is empty.

    message: explanation of the error.

    """
    def __init__(self, message):
        self.message = self.message = message

""" Class docstring """
class CircularBuffer:
    def __init__(self, capacity):
        """ Function docstring """
        self.capacity = capacity
        self.read_pos = -1
        self.write_pos = -1
        self.count = 0
        self.buffer = []
        for i in range(self.capacity):
            self.buffer.append("")


    def read(self):
        """ Function docstring """
        if self.count == 0:
            raise BufferEmptyException("Circular buffer is empty")
        self.read_pos += 1
        if self.read_pos >= self.capacity:
            self.read_pos = 0
        data = self.buffer[self.read_pos]
        self.count = self.count - 1
        return data

    def write(self, data):
        """ Function docstring """
        self.count += 1
        self.write_pos += 1
        if self.write_pos >= self.capacity:
            self.write_pos = 0
        self.buffer[self.write_pos] = data
        if self.count > self.capacity:
            raise BufferFullException("Circular buffer is full")


    def overwrite(self, data):
        """ Function docstring """
        self.buffer[self.write_pos] = data

    def clear(self):
        """ Function docstring """
        self.read_pos = -1
        self.write_pos = -1
        self.buffer = []
