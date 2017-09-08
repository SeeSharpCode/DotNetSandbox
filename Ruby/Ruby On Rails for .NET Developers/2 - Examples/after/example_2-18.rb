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

p = System::Drawing::Printing::PrintController.new
p.print

module Math

  def add(x,y)
    x + y
  end

  def sub(x,y)
    x - y
  end

  def mul(x,y)
    x * y
  end

  def div(x,y)
    x / y
  end

  module MoreMath

    def mod(x,y)
      x % y
    end

  end

  class Calculator
    include Math
  end

end

module Power

  def get_power_from_sun
    puts "Powered by the sun!"
  end

end

class FancyCalculator < Math::Calculator

  include Power
  include Math::MoreMath

end