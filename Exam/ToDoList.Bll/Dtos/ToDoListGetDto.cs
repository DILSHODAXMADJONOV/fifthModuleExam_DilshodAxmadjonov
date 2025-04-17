﻿namespace ToDoList.Bll.Entities;

public class ToDoListGetDto
{
    public long ToDoItemId { get; set; }
    public string Title { get; set; }
    public string Discription { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime DueDate { get; set; }
}
