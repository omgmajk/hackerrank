# Csharp not available in challenge

class TestDataEmptyArray(object):
    @staticmethod
    def get_array():
        return []

class TestDataUniqueValues(object):
    @staticmethod
    def get_array():
        return [1, 2, 3, 4, 5, 6, 7]

    @staticmethod
    def get_expected_result():
        return 0

class TestDataExactlyTwoDifferentMinimums(object):
    @staticmethod
    def get_array():
        return [1, 2, 3, 1, 4]

    @staticmethod
    def get_expected_result():
        return 0
