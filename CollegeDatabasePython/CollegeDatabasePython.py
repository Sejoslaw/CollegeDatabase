from CollegeDb import CollegeDb
from Professor import Professor
from Student import Student
from DegreeFactory import DegreeFactory
from StudentDecorator import StudentDecorator

import uuid
import sys

# Main Method
def main():
    # Stworz nową bazę
    db = CollegeDb()

    # Dodaj Profesorow
    db.AddPerson(Professor("Andrzej", "Kowalski", "Prof."))
    db.AddPerson(Professor("Monika", "Radzka", "Dr."))

    # Dodaj studentów
    db.AddPerson(Student("Jan", "Rybak", uuid.uuid4()))
    db.AddPerson(Student("Krzysztof", "Dobrzyński", uuid.uuid4()))
    db.AddPerson(Student("Maria", "Łudzka", uuid.uuid4()))

    # Policz ile osób zostało zarejestrowanych
    print("Registered Persons = " + str(len(db.People)))

    input("Press key to close...")
    
if __name__ == "__main__":
    sys.exit(int(main() or 0));