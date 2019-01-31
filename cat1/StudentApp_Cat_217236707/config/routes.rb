Rails.application.routes.draw do
  resources :students
  get 'students/new'
  get 'students/edit'
  get 'students/show'
  get 'students/destroy'
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
end
