class StoresController < ApplicationController
  def index
    @store = Store.all 
  end

  def new
    @store = Store.new   
  end

  def create
    @store = Store.new(store_params)
        
    if @store.save   
      redirect_to stores_path, notice: "Successfully uploaded."   
   else   
      render "new"   
   end      
  end

  def destroy
    @store = Store.find(params[:id])   
    @store.destroy   
    redirect_to stores_path, notice:  "Successfully deleted."  
  end
  private   
  def store_params   
  params.require(:store).permit(:title, :category, :price, :year, :attachment)   
  end   
end
