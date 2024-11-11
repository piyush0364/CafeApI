﻿using System;
using System.Collections.Generic;

namespace WebApICafe.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? UserId { get; set; }

    public string? Status { get; set; }

    public int? PaymentId { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Payment? Payment { get; set; }

    public virtual User? User { get; set; }
}
