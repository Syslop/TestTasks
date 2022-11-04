package com.example.usersRegistrationSinglePageApp.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;


@Controller
public class IndexController {

    @GetMapping(value = "/users")
    public String helloWorldController()
    {
        return "users";
    }
}
