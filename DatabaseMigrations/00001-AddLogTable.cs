using FluentMigrator;

namespace bballsim.simulation.DatabaseMigrations
{
    [Migration(00001)]
    public class M_00001_AddLogTable : Migration
    {
        public override void Up()
        {
            Create.Table("Log")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Text").AsString();
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}