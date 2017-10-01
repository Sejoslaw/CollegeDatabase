class DegreeFactory(object):

    def __init__(self):
        self.Degrees = dict()

    def NewFactory():
        return DegreeFactory()

    def Degrees(self):
        return self.Degrees

    def AddDegreeForPerson(self, person, degree):
        self.Degrees.update(person, degree);

