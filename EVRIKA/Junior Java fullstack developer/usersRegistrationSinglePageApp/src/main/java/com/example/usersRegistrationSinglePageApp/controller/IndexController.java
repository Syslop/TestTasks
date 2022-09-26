package com.example.usersRegistrationSinglePageApp.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;


@Controller
public class IndexController {

    @GetMapping(value = "/users")
    public String helloWorldController() {
        return "users.html";
    }
}
