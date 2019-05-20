Migration Process:
enable-migrations -ContextTypeName InsuranceApp.DAL.CarContext -MigrationsDirectory:CarContextMigration
add-migration -configuration InsuranceApp.CarContextMigration.Configuration Initial
//Fresh from remote? Please update database:
update-database -configuration InsuranceApp.CarContextMigration.Configuration -Verbose