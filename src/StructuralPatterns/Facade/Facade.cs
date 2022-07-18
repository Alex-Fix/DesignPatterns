using Facade.Subsystems;

namespace Facade;

internal class Facade
{
      private readonly SubsystemA _subsystemA;
      private readonly SubsystemB _subsystemB;
      private readonly SubsystemC _subsystemC;

      internal Facade(SubsystemA subsystemA, SubsystemB subsystemB, SubsystemC subsystemC)
      {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
            _subsystemC = subsystemC;
      }

      internal void Operation()
      {
            _subsystemA.A1();
            _subsystemB.B1();
            _subsystemC.C1();
      }
}
