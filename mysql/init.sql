GRANT ALL PRIVILEGES ON * . * TO 'atip'@'%' ;

CREATE TABLE `transection` (
  `transection_id` binary(16) NOT NULL,
  `transection_owner` binary(16) NOT NULL,
  `transection_type` varchar(45) NOT NULL,
  `transection_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `transection_balance` int NOT NULL,
  `transection_user_referrence` binary(16),
  `transection_amount` int NOT NULL,
  PRIMARY KEY (`transection_id`),
  UNIQUE KEY `transection_id_UNIQUE` (`transection_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `user` (
  `user_id` binary(16) NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `user_birthday` date NOT NULL,
  `user_balance` int NOT NULL,
  `user_lastname` varchar(45) NOT NULL,
  `user_username` varchar(45) NOT NULL,
  `user_password` text NOT NULL,
  `is_enable` tinyint NOT NULL,
  `user_created_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `banking`.`transection`
(`transection_id`,
`transection_owner`,
`transection_type`,
`transection_balance`,
`transection_user_referrence`,
`transection_amount`)
VALUES
(uuid_to_bin('d22d29b6-145d-4bb3-b413-10613f53b555'),uuid_to_bin('33e0a34d-f268-4782-a4cf-720ab6ee58d9'),'DEP',
0,null,2000);

INSERT INTO `banking`.`transection`
(`transection_id`,
`transection_owner`,
`transection_type`,
`transection_balance`,
`transection_user_referrence`,
`transection_amount`)
VALUES
(uuid_to_bin('6aaaa0d3-a561-4719-a1c1-dd5a7316bd29'),uuid_to_bin('33e0a34d-f268-4782-a4cf-720ab6ee58d9'),'WIT',
2000,null,100);

INSERT INTO `banking`.`user`
(`user_id`,
`user_name`,
`user_birthday`,
`user_balance`,
`user_lastname`,
`user_username`,
`user_password`,
`is_enable`)
VALUES
(uuid_to_bin('6aaaa0d3-a561-4719-a1c1-dd5a7316bd29'),'atip',
'2001-04-22',0,'nasakun',
'atip',
'test',
1);