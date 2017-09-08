class A
  def main_method
    method1
  end

  def method1
    puts "hello from #{self.class}"
  end

  def method2
    puts "hello from #{self.class}"
  end
end

class B < A
  def main_method
    method1
  end
end

class C < A
  def main_method
    self.method1
  end
end

A.new.main_method
B.new.main_method
C.new.main_method
