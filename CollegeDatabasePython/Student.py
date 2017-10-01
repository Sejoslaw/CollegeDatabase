from AbstractPerson import AbstractPerson
import string

class Student(AbstractPerson):
    
    def __init__(self, firstName, lastName, groupId):
        AbstractPerson.__init__(self, firstName, lastName)
        self.GroupId = groupId

    def GroupId(self):
        return self.GroupId

    def ToString(self):
        return "Student[Id = {0}, First Name = {1}, Last Name {2}, GroupId = {3}]".format(self.Id, self.FirstName, self.LastName, self.GroupId);