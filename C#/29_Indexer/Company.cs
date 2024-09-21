/*
public class Company {

    public string name { get; set; }
    private Employee[] _employee;
    public Company(Employee[] obj) {

        _employee = obj;
    }


    public void PrintEmployee() {

        if (_employee != null && _employee.Length > 0) {

            foreach (Employee e in _employee) {

                Console.WriteLine(e.id);
                Console.WriteLine(e.name);
                Console.WriteLine(e.rollNo);
            }
        }

    }

    public string this[int id] {

        get {

            string name = "Not Found";
            foreach (Employee e in _employee) {

                if (e.id == id) { 
                
                    name = e.name;
                }
            }
            return name;
        }

        set {

            foreach (Employee e in _employee) {

                if (e.id == id) { 

                    e.name = value;
                }
            }
        }
    }
}*/
