Rails.application.routes.draw do
  root 'person#index'
  post 'person' => 'person#create'
  get 'person' => 'person#read'
  patch 'person/:id' => 'person#update'
  delete 'person/:id' => 'person#delete'
  # For details on the DSL available within this file, see https://guides.rubyonrails.org/routing.html
end
