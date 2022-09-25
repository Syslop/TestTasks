package com.example.usersRegistrationSinglePageApp;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.jdbc.DataSourceAutoConfiguration;

@SpringBootApplication(exclude = {DataSourceAutoConfiguration.class})
public class UsersRegistrationSinglePageAppApplication {

	public static void main(String[] args) {
		SpringApplication.run(UsersRegistrationSinglePageAppApplication.class, args);
	}

}
