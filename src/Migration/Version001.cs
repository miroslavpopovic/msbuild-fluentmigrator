namespace Migration
{
    [FluentMigrator.Migration(1)]
    public class Version001 : FluentMigrator.Migration
    {
        public override void Up()
        {
            Alter.Table("Products")
                .AddColumn("CategoryName").AsString(Constants.DefaultLengthString);
        }

        public override void Down()
        {
            Delete.Column("CategoryName").FromTable("Products");
        }
    }
}