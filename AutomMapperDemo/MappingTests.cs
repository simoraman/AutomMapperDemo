using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AutoMapper;

namespace AutomMapperDemo
{

    [TestFixture]
    public class MappingTests
    {
        [Test]
        public void TestConventions() {
            Mapper.CreateMap<Person, PersonDTO>();
            Person p = new Person { FirstName="Bruce", LastName="Wayne", SecretId="Batman" };
            PersonDTO personDto = Mapper.Map<Person, PersonDTO>(p);
            Assert.That(personDto.FirstName, Is.EqualTo("Bruce"));
            Assert.That(personDto.LastName, Is.EqualTo("Wayne"));
        }

    }
}
