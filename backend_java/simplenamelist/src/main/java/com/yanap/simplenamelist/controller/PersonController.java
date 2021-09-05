package com.yanap.simplenamelist.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PatchMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
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

	@GetMapping("/person")
	public ListResponse index() {
		return new ListResponse(service.findAll());
	}

	@PostMapping("/person")
	public ResultResponse add(@RequestBody Person person) {
		return new ResultResponse(service.add(person));
	}

	@PatchMapping("/person/{id}")
	public ResultResponse update(@PathVariable("id") long id, @RequestBody Person person) {
		person.setid(id);
		return new ResultResponse(service.update(person));
	}

	@DeleteMapping("/person/{id}")
	public ResultResponse delete(@PathVariable("id") long id) {
		return new ResultResponse(service.delete(id));
	}
}
