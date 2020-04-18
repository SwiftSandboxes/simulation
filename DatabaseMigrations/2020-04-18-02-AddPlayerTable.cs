using FluentMigrator;

namespace simulation
{
    [Migration(2020041802)]
    public class Player : Migration
    {
        public override void Up()
        {
            Create.Table("Player")
                .WithColumn("PlayerId").AsInt64().PrimaryKey().Identity()
                .WithColumn("Appearance").AsString()
                .WithColumn("FirstName").AsString()
                .WithColumn("LastName").AsString()
                .WithColumn("Overall").AsInt32()
                .WithColumn("Assisting").AsInt32()
                .WithColumn("Blocking").AsInt32()
                .WithColumn("Rebounding").AsInt32()
                .WithColumn("Scoring").AsInt32()
                .WithColumn("Stealing").AsInt32()
                .WithColumn("ThreePointScoring").AsInt32();
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}