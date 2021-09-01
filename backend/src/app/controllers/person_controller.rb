class PersonController < ApplicationController
  skip_forgery_protection

  def index
    response = { message: "Person", result: true }
    render json: response
  end
  
  def create
    response = { result: false }

    last_name = params["last_name"]
    first_name = params["first_name"]
    person = Person.new(last_name: last_name, first_name: first_name)
    if person.save then
      response[:result] = true
    end

    render json: response
  end

  def read
    list = Person.all
    response = { list: list }

    render json: response
  end

  def update
    response = { result: false }

    last_name = params["last_name"]
    first_name = params["first_name"]
    person = Person.find_by(id: params[:id])
    if person != nil then
      person.first_name = first_name
      person.last_name = last_name
      if person.save then
        response[:result] = true
      end
    end

    render json: response
  end

  def delete
    response = { result: false }

    person = Person.find_by(id: params[:id])
    if person != nil && person.destroy then
      response[:result] = true
    end

    render json: response
  end
end
