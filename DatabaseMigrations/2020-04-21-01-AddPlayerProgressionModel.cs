using FluentMigrator;

namespace bballsim.league.simulation.DatabaseMigrations
{
    [Migration(2020042101)]
    public class M_2020_04_21_01_AddPlayerProgressionModel : Migration
    {
        public override void Up()
        {
            Create.Table("PlayerProgressionModel")
                .WithColumn("PlayerProgressionModelId").AsInt32().PrimaryKey().Identity()
                .WithColumn("ModelName").AsString();
                //More to come
        }

        public override void Down()
        {
            Delete.Table("PlayerProgressionModel");
        }
    }
}