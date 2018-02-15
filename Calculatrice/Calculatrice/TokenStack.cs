
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class TokenStack
    {
            /** Member variables **/
            private ObservableCollection<Token> tokens;

            /** Constructors **/
            public TokenStack()
            {
                tokens = new ObservableCollection<Token>();
            }

            /** Accessor methods **/
            public bool isEmpty()
            {
                return tokens.Count == 0;
            }
            public Token top()
            {
                return tokens[tokens.Count - 1];
            }
            public ObservableCollection<Token> getTokens()
            {
                return tokens;
            }
            /** Mutator methods **/
            public void push(Token t)
            {
                tokens.Add(t);
            }
            public void pop()
            {
                tokens.Remove(tokens[tokens.Count - 1]);
            }
        }
    }

