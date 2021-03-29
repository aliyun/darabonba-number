import unittest

from alibabacloud_darabonba_number.client import Client


class TestClient(unittest.TestCase):
    def test_parse_int(self):
        self.assertEqual(100, Client.parse_int('100'))

    def test_parse_long(self):
        self.assertEqual(100, Client.parse_long('100'))

    def test_parse_double(self):
        self.assertEqual(100.0, Client.parse_float('100'))
        self.assertEqual(100.1, Client.parse_float('100.1'))

    def test_parse_float(self):
        self.assertEqual(100.0, Client.parse_float('100'))
        self.assertEqual(100.1, Client.parse_float('100.1'))

    def test_itol(self):
        self.assertEqual(100, Client.itol(100))

    def test_ltoi(self):
        self.assertEqual(100, Client.ltoi(100))

    def test_add(self):
        self.assertEqual(200, Client.add(100, 100))

    def test_sub(self):
        self.assertEqual(50, Client.sub(100, 50))

    def test_mul(self):
        self.assertEqual(100, Client.mul(10, 10))

    def test_div(self):
        self.assertEqual(10.0, Client.div(100, 10))

    def test_gt(self):
        self.assertTrue(Client.gt(2, 1))
        self.assertFalse(Client.gt(1, 2))
        self.assertFalse(Client.gt(1, 1))

    def test_gte(self):
        self.assertTrue(Client.gte(2, 1))
        self.assertFalse(Client.gte(1, 2))
        self.assertTrue(Client.gte(1, 1))

    def test_lt(self):
        self.assertTrue(Client.lt(1, 2))
        self.assertFalse(Client.lt(2, 1))
        self.assertFalse(Client.lt(1, 1))

    def test_lte(self):
        self.assertTrue(Client.lte(1, 2))
        self.assertFalse(Client.lte(2, 1))
        self.assertTrue(Client.lte(1, 1))
