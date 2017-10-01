import uuid

class AbstractPerson(object):
    
    def __init__(self, firstName, lastName):
        self.Id = uuid.uuid4()
        self.FirstName = firstName
        self.LastName = lastName

    def Id(self):
        return self.Id

    def FirstName(self):
        return self.FirstName

    def LastName(self):
        return self.LastName;