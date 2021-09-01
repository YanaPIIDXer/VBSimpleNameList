class PersonController < ApplicationController
  def index
    response = { message: "Person", result: true }
    render json: response
  end
  
  def create
    response = { result: false }

    render json: response
  end

  def read
    list = []
    response = { list: list }

    render json: response
  end

  def update
    response = { result: false }

    render json: response
  end

  def delete
    response = { result: false }

    render json: response
  end
end
