// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HumanConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The human configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace by.grsu.mf.dzianishchyk.spacestation.model.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    /// <summary>
    /// The human configuration.
    /// </summary>
    public class HumanConfiguration : EntityTypeConfiguration<Human>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HumanConfiguration"/> class.
        /// </summary>
        public HumanConfiguration()
        {
            HasKey(human => human.Id).Property(human => human.Id).HasColumnName("HumanId");

            Property(human => human.FirstName).HasMaxLength(30).IsOptional();
            Property(human => human.MiddleName).HasMaxLength(30).IsOptional();
            Property(human => human.LastName).HasMaxLength(30).IsRequired();
        }
    }
}
