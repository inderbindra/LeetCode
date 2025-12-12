# Last updated: 12/11/2025, 8:00:41 PM
class MyHashMap:

    def __init__(self):
        self.Data = [None] * 1000001

    def put(self, key: int, value: int) -> None:
        self.Data[key] = value

    def get(self, key: int) -> int:
        return -1 if self.Data[key] is None else self.Data[key]

    def remove(self, key: int) -> None:
        self.Data[key] = None


# Your MyHashMap object will be instantiated and called as such:
# obj = MyHashMap()
# obj.put(key,value)
# param_2 = obj.get(key)
# obj.remove(key)