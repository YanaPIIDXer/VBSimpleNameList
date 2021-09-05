package com.yanap.simplenamelist.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.yanap.simplenamelist.model.Person;
import com.yanap.simplenamelist.service.PersonService;

@RestController
public class PersonController {
	@Autowired
	private PersonService service;

	@RequestMapping("/person")
	public List<Person> Index() {
		return service.findAll();
	}
}
