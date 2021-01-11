import unittest

from alibabacloud_darabonba_number.client import Client


class TestClient(unittest.TestCase):
    def test_parse_int(self):
        self.assertEqual(100, Client.parse_int('100'))

    def test_parse_double(self):
        self.assertEqual(100.0, Client.parse_float('100'))
        self.assertEqual(100.1, Client.parse_float('100.1'))

    def test_parse_float(self):
        self.assertEqual(100.0, Client.parse_float('100'))
        self.assertEqual(100.1, Client.parse_float('100.1'))
