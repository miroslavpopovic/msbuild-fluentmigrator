namespace Migration
{
    [FluentMigrator.Migration(0)]
    public class Baseline : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("ProductId").AsInt64().PrimaryKey()
                .WithColumn("Name").AsString(Constants.DefaultLengthString)
                .WithColumn("Description").AsString(Constants.MaxLengthString)
                .WithColumn("Price").AsDecimal()
                ;
        }

        public override void Down()
        {
            // Nothing here... this is a baseline
        }
    }
}