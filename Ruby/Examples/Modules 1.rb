module Math
  def add(x,y)
    x + y
  end

  def subtract(x,y)
    x - y
  end

  module MoreMath
    def multiply(x,y)
      x * y
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

fancyCalc = FancyCalculator.new
fancyCalc.get_power_from_sun

puts fancyCalc.add 1,1
puts fancyCalc.multiply 3,3
