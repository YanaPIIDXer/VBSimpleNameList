package com.yanap.simplenamelist.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.yanap.simplenamelist.model.Person;
import com.yanap.simplenamelist.service.PersonService;

@RestController
public class PersonController {
	@Autowired
	private PersonService service;

	public class ResultResponse {
		public boolean result;

		public ResultResponse(boolean result) {
			this.result = result;
		}
	}

	public class ListResponse {
		public List<Person> list;

		public ListResponse(List<Person> list) {
			this.list = list;
		}
	}

	@RequestMapping("/person")
	public ListResponse Index() {
		return new ListResponse(service.findAll());
	}

	@PostMapping("/person")
	public ResultResponse Add(@RequestBody Person person) {
		System.out.println(person.toString());
		return new ResultResponse(false);
	}
}
