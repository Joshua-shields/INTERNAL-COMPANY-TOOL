namespace CRUD_APP_.Models;

public class User_model
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}

public class userloginmodel
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class User_ticket_model
{
    public int TicketId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}