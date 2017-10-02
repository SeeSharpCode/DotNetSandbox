package com.jbhunt.sandbox;

import lombok.AllArgsConstructor;
import lombok.Data;

public class Interfaces {
    @Data
    @AllArgsConstructor
    private class Foo {
        private String foo;
    }

    private interface Repository<T> {
        void Save(T t);
    }

    private class FooRepository implements Repository<Foo> {
        @Override
        public void Save(Foo foo) {

        }
    }
}
