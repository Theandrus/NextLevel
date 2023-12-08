namespace MYB
{
    using System;
    using MySql.Data.MySqlClient;

    public class Program
    {
        public static readonly string ConnectionString = "server=127.0.0.1;uid=root;pwd=uTnw0PIh65_!;database=cutsubsADO";

        static void Main(string[] args)
        {
            CreateDatabase();

            FillDatabaseWithTestData();

            Console.WriteLine("Displaying Actor Table Data:");
            DisplayActorsData();
            Console.WriteLine();

            Console.WriteLine("Displaying Characters Table Data:");
            DisplayCharactersData();
            Console.WriteLine();

            Console.WriteLine("Displaying Projects Table Data:");
            DisplayProjectsData();
            Console.WriteLine();

            Console.WriteLine("Displaying Project Casts Table Data:");
            DisplayProjectCastsData();
            Console.WriteLine();
        }


        public static void DisplayProjectCastsData()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM ProjectCasts";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, ActorId: {reader["ActorId"]}, CharacterId: {reader["CharacterId"]}");
                    }
                }
            }
        }

        public static void DisplayProjectsData()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Projects";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, ProjectName: {reader["ProjectName"]}");
                    }
                }
            }
        }

        public static void DisplayCharactersData()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Characters";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, CharacterName: {reader["CharacterName"]}, ProjectId: {reader["ProjectId"]}");
                    }
                }
            }
        }

        public static void DisplayActorsData()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Actors";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, actorName: {reader["actorName"]}");
                    }
                }
            }
        }

        public static void FillDatabaseWithTestData()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery0 = "INSERT INTO Actors (ActorName) VALUES (@actorName)";

                for (int i = 0; i < 50; i += 1)
                {
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery0, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@actorName", $"actor{i}");
                        insertCommand.ExecuteNonQuery();
                    }
                }

                string insertQuery1 = "INSERT INTO Characters (CharacterName) VALUES (@characterName)";

                for (int i = 0; i < 50; i++)
                {
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery1, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@characterName", $"Character no. {i}");
                        insertCommand.Parameters.AddWithValue("@ProjectId", i + 1);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                string insertQuery2 = "INSERT INTO Projects (ProjectName) VALUES (@projectName)";

                for (int i = 0; i < 50; i++)
                {
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery2, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@projectName", $"Project no. {i}");
                        insertCommand.ExecuteNonQuery();
                    }
                }

                string insertQuery3 = "INSERT INTO ProjectCasts (ActorId, CharacterId) VALUES (@actorId, @characterId)";

                for (int i = 0; i < 50; i++)
                {
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery3, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@actorId", i + 1);
                        insertCommand.Parameters.AddWithValue("@characterId", i + 1);
                        insertCommand.Parameters.AddWithValue("@projectId", i + 1);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void CreateDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string createTableActor =
                @"CREATE TABLE IF NOT EXISTS Actors(
	                Id INT AUTO_INCREMENT NOT NULL,
	                ActorName VARCHAR(30) NOT NULL,
                    CHECK (LENGTH(ActorName) >= 5),
                    PRIMARY KEY (Id)
                );";

                string createTableProject =
                @"CREATE TABLE IF NOT EXISTS Projects(
	                Id INT AUTO_INCREMENT NOT NULL,
	                ProjectName VARCHAR(30) NOT NULL,
                    CHECK (LENGTH(ProjectName) >= 5),
                    PRIMARY KEY (Id)
                );";

                string createTableCharacter =
                @"CREATE TABLE IF NOT EXISTS Characters(
	                Id INT AUTO_INCREMENT NOT NULL,
	                CharacterName VARCHAR(30) NOT NULL,
                    ProjectId INT,
                    CHECK (LENGTH(CharacterName) >= 5),
                    PRIMARY KEY (Id),
                    FOREIGN KEY (ProjectId) REFERENCES Projects(Id)
                );";

                string createTableProjectCast =
                @"CREATE TABLE IF NOT EXISTS ProjectCasts(
	                Id INT AUTO_INCREMENT NOT NULL,
                    ActorId INT,
                    CharacterId INT,
                    PRIMARY KEY (Id),
                    FOREIGN KEY (ActorId) REFERENCES Actors(Id),
                    FOREIGN KEY (CharacterId) REFERENCES Characters(Id)
	            );";

                using (MySqlCommand command = new MySqlCommand(createTableActor, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(createTableProject, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(createTableCharacter, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(createTableProjectCast, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}