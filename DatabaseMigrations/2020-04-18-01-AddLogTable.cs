using FluentMigrator;

namespace bballsim.league.simulation.DatabaseMigrations
{
    [Migration(2020041801)]
    public class M_2020_04_18_01_AddLogTable : Migration
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