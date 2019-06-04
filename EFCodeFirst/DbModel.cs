namespace EFCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class DbModel : DbContext
    {
        // Your context has been configured to use a 'DbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EFCodeFirst.DbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbModel' 
        // connection string in the application configuration file.
        public DbModel()
            : base("name=DbModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Klijent> Klijents { get; set; }
        public DbSet<Servis> Servis { get; set; }

    }

    [Table("Klijenti", Schema = "dbo")]
    public class Klijent
    {

        public Klijent()
        {
            Servisi = new List<Servis>();
        }

        [Key, Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Morate uneti ime klijenta"), MaxLength(40, ErrorMessage = "Ime ne moze biti duze od 40 karaktera")]
        public string NazivKlijenta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Morate uneti registarski broj klijenta"), MaxLength(20, ErrorMessage = "Registarski broj ne moze biti duzi od 20 karaktera")]
        public string RegistarskiBroj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Morate uneti kontakt"), MaxLength(40, ErrorMessage = "Kontakt ne moze biti duzi od 40 karaktera")]
        public string Kontakt { get; set; }

        [MaxLength(200, ErrorMessage = "Komentar ne moze biti duzi od 200 karaktera")]
        public string DodatniKomentar { get; set; }

        public virtual ICollection<Servis> Servisi { get; set; }

    }

    [Table("Servisi", Schema = "dbo")]
    public class Servis
    {

        [Key, Required]
        public int Id { get; set; }       

        [Required(AllowEmptyStrings = false, ErrorMessage = "Morate uneti datum usluge")]
        public DateTime DatumServisa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Morate uneti opis usluge"), MaxLength(400, ErrorMessage = "Opis ne moze biti duzi od 400 karaktera")]
        public string OpisUsluge { get; set; }

        [Required, ForeignKey("Klijent")]
        public int KlijentId { get; set; }

        public Klijent Klijent { get; set; }
    }
}