using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Models;

namespace ProShop.Core.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class EntityTests
    {
        private class DummyEntity :
            Entity<long>
        {
            public string Property { get; }

            public DummyEntity(
                long id,
                string property)
                : base(id)
            {
                Property = property;
            }
        }

        [TestMethod]
        public void Two_entities_with_same_id_should_be_equal()
        {
            var first = new DummyEntity(1, "a");
            var second = new DummyEntity(1, "b");

            AssertAreEqual(first, second);
        }

        [TestMethod]
        public void Two_entities_with_different_id_are_not_equal()
        {
            var first = new DummyEntity(1, "a");
            var second = new DummyEntity(2, "a");

            AssertAreNotEqual(first, second);
        }

        [TestMethod]
        public void Non_null_entity_is_not_equal_to_null_entity()
        {
            var first = new DummyEntity(1, "a");
            DummyEntity second = null;

            AssertAreNotEqual(first, second);
        }

        [TestMethod]
        public void Two_entities_with_same_id_should_have_same_hash_code()
        {
            var first = new DummyEntity(1, "a");
            var second = new DummyEntity(1, "b");

            Assert.IsTrue(first.GetHashCode() == second.GetHashCode());
        }

        [TestMethod]
        public void Two_entities_with_different_id_do_not_have_same_hash_code()
        {
            var first = new DummyEntity(1, "a");
            var second = new DummyEntity(2, "a");

            Assert.IsTrue(first.GetHashCode() != second.GetHashCode());
        }

        [TestMethod]
        public void Two_null_entities_are_equal()
        {
            DummyEntity first = null;
            DummyEntity second = null;

            AssertAreEqual(first, second);
        }

        private static void AssertAreEqual(
            DummyEntity first, DummyEntity second)
        {
            Assert.AreEqual(first, second);
            Assert.AreEqual(second, first);

            Assert.IsTrue(first == second);
            Assert.IsTrue(second == first);

            Assert.IsFalse(first != second);
            Assert.IsFalse(second != first);
        }

        private static void AssertAreNotEqual(
            DummyEntity first, DummyEntity second)
        {
            Assert.AreNotEqual(first, second);
            Assert.AreNotEqual(second, first);

            Assert.IsFalse(first == second);
            Assert.IsFalse(second == first);

            Assert.IsTrue(first != second);
            Assert.IsTrue(second != first);
        }
    }
}
