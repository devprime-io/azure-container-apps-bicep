﻿namespace Application.Services.Order.Model;
public class OrderUpdatedEventDTO
{
    public Guid ID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerTaxID { get; set; }
    public double Total { get; set; }
}