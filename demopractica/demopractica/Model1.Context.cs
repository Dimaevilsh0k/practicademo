﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demopractica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class demotranningEntities : DbContext
    {
        public demotranningEntities()
            : base("name=demotranningEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Пункт_выдачи> Пункт_выдачи { get; set; }
        public virtual DbSet<Роли_пользователя> Роли_пользователя { get; set; }
        public virtual DbSet<Состав_заказа> Состав_заказа { get; set; }
        public virtual DbSet<Товар_декор> Товар_декор { get; set; }
    }
}
