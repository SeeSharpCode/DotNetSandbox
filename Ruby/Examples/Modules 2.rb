# modules can act as namespaces
module System
  module Drawing
    module Colors
      Red = 1
      Blue = 2
      Green = 3
    end

    module Printing
      class PrintController
        def print
          puts 'printing...'
        end
      end
    end
  end
end

puts System::Drawing::Colors::Red
printController = System::Drawing::Printing::PrintController.new
printController.print
