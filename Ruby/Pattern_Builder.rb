

class Product 
  attr_accessor :name
  attr_accessor :definitie
end

class IBuilder
    attr_accessor :product
    
    def initialize
        @product = Product.new
    end
    
    def build_name
        railse 'build_name nu este implementat  in mostenitor!'
      end
      
      def build_definitie
          raise 'build_definitie nu este implementat in mostenitor!'
      end
  end
  
  
  class ConcreteBuilder < IBuilder
      def build_name
          @product.name = 'Primul product'
        end
        
        def build_definitie
            @product.definitie = 'Defnitia primului produs'
        end
  end
  
  
  class TestBuilder < IBuilder
      def build_name
          @product.name = 'Produsul numarul 2'
        end
        
        def build_definitie
            @product.definitie = 'Defnitia pentru produsul 2'
        end
  end
  
  
  class Director
      attr_accessor :builder
      
      def product
          return @builder.product
        end
    
      def build_product
          @builder.build_name
          @builder.build_definitie
      end
    
  end
  
  
  
  d = Director.new
  d.builder =  ConcreteBuilder.new
  d.build_product

puts d.product.name + '  '+d.product.definitie


d.builder =  TestBuilder.new
d.build_product

puts d.product.name + '  '+d.product.definitie


#end