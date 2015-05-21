// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataContext.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DataContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;

    /// <summary>
    /// The data context.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        public DataContext()
            : base("connectionString")
        {
        }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            foreach (Type type in this.GetType().Assembly.GetTypes().Where(x => x.BaseType != null && x.BaseType.IsGenericType && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToList())
            {
                dynamic confobj = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(confobj);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
