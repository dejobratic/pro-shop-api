﻿using System;

namespace ProShop.Core.Tests.Unit.Helpers
{
    public static class DateTimeProvider
    {
        public static readonly DateTime Today
            = DateTime.UtcNow.Date;

        public static readonly DateTime MinValue
            = DateTime.MinValue;
    }
}
