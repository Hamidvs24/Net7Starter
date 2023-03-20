﻿

using CORE.Enums;
using CORE.Helper;
using ENTITIES.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.CustomMigrations;

public class UserSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        string salt = SecurityHelper.GenerateSalt();
        string pass = SecurityHelper.HashPassword("testtest", salt);
        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                Username = "Test",
                Email = "test@test.tst",
                Password = pass,
                ContactNumber = "",
                RoleId = 1,
                Salt = salt
            }
        );
    }
}