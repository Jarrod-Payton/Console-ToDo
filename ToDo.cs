namespace ToDo
{
  class ToDo
  {
    public bool Playing { get; private set; }
    public ToDo()
    {
      Playing = true;
      Console.Clear();
      while (Playing)
      {
        GetPlayerInput();
      }
    }
    private void GetPlayerInput()
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("What would you like to do?");
      string input = Console.ReadLine();
      Start(input);
    }
    private void Start(string input)
    {
      string action = input.Split(" ")[0].ToLower();
      switch (action)
      {
        case "create":
          Console.Clear();
          CreateList();
      }
    }
    private void CreateList()
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("What would you like your list to be named?");
      string Name = Console.ReadLine();
      List List = new List(Name);
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("You made a list named" + List);
      Interact(List);
    }
    private void Interact(List List)
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("What would you like to do with this list?");
      string input = Console.ReadLine();
      switch (input)
      {
        case "quit":
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("Have a good rest of your day");
          Playing = false;
        case "Create"
        MakeToDo(List);
      }
    }
    private void MakeToDo(List List)
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("What would you like to add to this list");
      string ToDo = Console.ReadLine();
      Item newTodo = new Item(ToDo);

    }
  }
}