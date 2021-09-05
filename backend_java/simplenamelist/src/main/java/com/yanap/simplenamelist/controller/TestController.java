package com.yanap.simplenamelist.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class TestController {
    public class HelloWorld {
        public String message;

        public HelloWorld() {
            this.message = "Hello, World";
        }
    }

    @RequestMapping("/")
    @ResponseBody
    public HelloWorld[] Index() {
        HelloWorld[] list = { new HelloWorld(), new HelloWorld(), new HelloWorld() };
        return list;
    }
}
