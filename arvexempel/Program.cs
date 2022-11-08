Human human = new Human();
Student student = new Student();

Random rnd = new Random();
while(true) {
    human.Age = rnd.Next(0, 101);
    Console.WriteLine(human.Age);
    Console.WriteLine(student.Name);
}