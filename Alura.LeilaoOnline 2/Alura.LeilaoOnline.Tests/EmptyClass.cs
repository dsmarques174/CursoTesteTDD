using System;
namespace Alura.LeilaoOnline.Tests
{
    public class EmptyClass
    {
        public EmptyClass()



        {



            [Fact]
            public void OrderMealDoesNotExists()
            {
                var id = -100;
                var meal = MealRepository.GetById(id);
                Assert.Throws<System.NullReferenceException>(
                    () => new PrepareMeal(meal)
                );
            }


            [Theory]
            [InlineData(new double[] { 100, 200, 300, 400 })]
            public void OrderWithinNMeals(int[] mealsId)
            {

                //Arranje - cenário
                PrepareMeal prepareMeal = null;
                var leilao = new Leilao("Van Gogh", modalidade);
                var fulano = new Interessada("Fulano", leilao);
                var maria = new Interessada("Maria", leilao);

                leilao.IniciaPregao();

                for (int i = 0; i < mealsId.Length; i++)
                {
                    try
                    {

                        var meal = MealRepository.GetById(mealsId[i]);
                        prepareMeal = new PrepareMeal(meal);


                        Meal meal = MealRepository.GetById(id);

                        var valor = ofertas[i];

                    }
                    catch (Exception ex)
                    {

                    }
                }

                //Act - método sob teste
                leilao.TerminaPregao();

                //Assert
                var valorObtido = leilao.Ganhador.Valor;
                Assert.Equal(valorEsperado, valorObtido);

            }


        }
    }
}
