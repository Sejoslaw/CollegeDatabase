from AbstractPerson import AbstractPerson

class Professor(AbstractPerson):
    
    def __init__(self, firstName, lastName, title):
        AbstractPerson.__init__(self, firstName, lastName)
        self.Title = title

    def Title(self):
        return self.Title

    def ToString(self):
        return "Professor[Id = {0}, First Name = {1}, Last Name {2}, Title = {3}]".format(self.Id, self.FirstName, self.LastName, self.Title);