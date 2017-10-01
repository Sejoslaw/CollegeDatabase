from Student import Student

class StudentDecorator(object):

    def __init__(self, student):
        self.Student = student

    def FirstName(self):
        return self.Student.FirstName + " (udekorowane imie Studenta)"

    def ToString(self):
        return self.Student.ToString() + " - udekorowany";