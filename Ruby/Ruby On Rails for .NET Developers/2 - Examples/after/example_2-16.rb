class A
  def main_method
    method1
  end

  protected
  def method1
    puts "hello from #{self.class}"
  end

  private
  def method2
    puts "hello from #{self.class}"
  end

end

class B < A
  def main_method
    method1
  end
end

class C
  def main_method
    b = B.new
    b.method1
  end
end

A.new.main_method
B.new.main_method
C.new.main_method
