# Last updated: 12/11/2025, 8:00:38 PM
class MyHashSet:

    def __init__(self):
        self.Data = []

    def add(self, key: int) -> None:
        if key not in self.Data:
            self.Data.append(key)

    def remove(self, key: int) -> None:
        if key in self.Data:
            self.Data.remove(key)

    def contains(self, key: int) -> bool:
        return key in self.Data
        


# Your MyHashSet object will be instantiated and called as such:
# obj = MyHashSet()
# obj.add(key)
# obj.remove(key)
# param_3 = obj.contains(key)